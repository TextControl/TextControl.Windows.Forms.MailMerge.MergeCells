using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp87 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		Order report;

		private void Form1_Load(object sender, EventArgs e) {
			// read json from file
			string json = File.ReadAllText("report.json");

			// create object
			report = JsonConvert.DeserializeObject<Order>(json);

			ribbonReportingTab1.DataSourceManager.LoadSingleObject(report);
		}

		private void button1_Click(object sender, EventArgs e) {
			
			// merge data
			using (TXTextControl.DocumentServer.MailMerge mm =
				new TXTextControl.DocumentServer.MailMerge()) {
				mm.TextComponent = textControl1;
				mm.BlockRowMerged += Mm_BlockRowMerged;
				mm.MergeObject(report);
			}

			// loop through all tables, find flagged block tables
			// and pass them to "MergeSimilarColumns"
			foreach (TXTextControl.Table table in FindBlockTables(textControl1)) {
				MergeSimilarCells(table);
			}
		}

		private List<TXTextControl.Table> FindBlockTables(TXTextControl.TextControl textControl) {

			// create a list of block tables by searching of the
			// cell name "block_identifier"
			List<TXTextControl.Table> tables = new List<TXTextControl.Table>();

			// loop through all tables...
			foreach (TXTextControl.Table table in textControl.Tables) {

				// to check whether there is a merge block table
				foreach (TXTextControl.TableRow row in table.Rows) {
					if (table.Cells.GetItem(row.Row, 1).Name == "block_identifier") {
						tables.Add(table);
						break;
					}
				}

			}

			return tables;
		}

		private bool MergeSimilarCells(TXTextControl.Table table, bool firstIteration = true) {
			
			// loop through all column separately
			foreach (TXTextControl.TableColumn col in table.Columns) {

				bool bMergeFlag = false;
				int iFirstRow = 0;
				string sCommonCellText = "";

				// row by row
				for (int row = 1; row <= table.Rows.Count; row++) { 

					// only cells that are not merged
					if (table.Cells[row, col.Column].Length != -1) {

						// if table cell contains text from previous cell
						// set "bMergeFlag" to true and flag row number
						if (table.Cells[row, col.Column].Text == sCommonCellText) {
							if (bMergeFlag == false) iFirstRow = row;
							bMergeFlag = true;
						}
						// if text is different and "bMergeFlag" is true, merge cells
						else if (bMergeFlag == true) {
							MergeCells(table, iFirstRow - 1, col.Column, row - 1, col.Column, sCommonCellText);
							bMergeFlag = false;
						}

						// if flag "bMergeFlag" is true and it is the last row, merge cells
						if (bMergeFlag == true &&
							row == table.Rows.Count &&
							table.Cells[row, col.Column].Text == sCommonCellText) {
							MergeCells(table, iFirstRow - 1, col.Column, row, col.Column, sCommonCellText);
						}

						// remember current cell text
						if (row < table.Rows.Count)
							sCommonCellText = table.Cells[row, col.Column].Text;
						
					}

				}
			}

			// two iterations required as rows are potentially merged
			if (firstIteration == true)
				MergeSimilarCells(table, false);

			return false;
		}

		// this method simply merges given cells and sets the common cell text
		private void MergeCells(
			TXTextControl.Table table,
			int startRow,
			int startColumn,
			int stopRow,
			int stopColumn,
			string newText) {

			table.Select(startRow, startColumn, stopRow, stopColumn);
			table.MergeCells();
			table.Cells[startRow, startColumn].Text = newText;
		}

		private void Mm_BlockRowMerged(object sender, TXTextControl.DocumentServer.MailMerge.BlockRowMergedEventArgs e) {
			
			using (TXTextControl.ServerTextControl tx = new TXTextControl.ServerTextControl()) {
				tx.Create();
				tx.Load(e.MergedBlockRow, TXTextControl.BinaryStreamType.InternalUnicodeFormat);

				// find all tables in a block and flag cell 1,1
				if (tx.Tables.GetItem() != null) {
					tx.Tables.GetItem().Cells.GetItem(1, 1).Name = "block_identifier";
				}

				byte[] data;

				tx.Save(out data, TXTextControl.BinaryStreamType.InternalUnicodeFormat);
				e.MergedBlockRow = data;
			}

		}

	}
}
