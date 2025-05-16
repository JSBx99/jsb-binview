using System.Text;

namespace jsb_binview
{
	public partial class frmMain : Form
	{
		//Variables
		string binFileLocation = "D:\\Data\\binit\\binit.bin";

		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{

		}

		private void OpenBinaryFile()
		{


			using (BinaryReader breader = new BinaryReader(new FileStream(binFileLocation, FileMode.Open)))
			{
				byte[] bHead = breader.ReadBytes(4); //Get header bytes
				byte[] bFileStructureType = breader.ReadBytes(2); //Get file structure type bytes
				byte[] bBinaryVersion = breader.ReadBytes(2); //Get binary version
				string sbHead = Encoding.ASCII.GetString(bHead);
				string sbFileStructureType = Encoding.ASCII.GetString(bFileStructureType);
				string sbBinaryVersion = Encoding.ASCII.GetString(bBinaryVersion);

				if (sbHead == "JSB>")
				{
					if (sbFileStructureType == "BN")
					{
						//Check which binary version this file is
						switch (sbBinaryVersion)
						{
							case "01":
								MessageBox.Show("This is a JSB binary version 1 file");
								breader.Close(); //Close the file so that it can re-opened for getting the data chunk count
								DisplayDataChunkList(1);
								break;
							case "02":
								MessageBox.Show("ERROR! Version 2 binary file support has not yet been implemented.");
								return;
						}
					}
					else
					{
						MessageBox.Show("Invalid file type! Got: " + sbFileStructureType + " Expected: BN");
						return;
					}
				}
				else
				{
					MessageBox.Show("Invalid header! Got: " + sbHead + " Expected: JSB>");
					return;
				}



				MessageBox.Show(Encoding.ASCII.GetString(bHead));
			}
		}

		private void DisplayDataChunkList(int bVersion)
		{
			//Work out which type of binary to display data for
			switch (bVersion)
			{
				case 1:
					ClearEverything();
					txtBinaryVersion.Text = "Version 1 - File Storage (BN01)";
					//Need to find out how many 'files' are contained in this v1 binary
					int dCount = GetDataChunkCount(binFileLocation, 1);
					txtDataChunkCount.Text = "Files (" + dCount + ")";

					//Call the function to load files into data view along with the data size
					DisplayVersion1FileInfo(dCount);
					break;
			}
		}

		private void ClearEverything()
		{
			//Clear all text boxes and the data view
			txtBinaryVersion.Clear();
			txtDataChunkCount.Clear();
		}

		private static int GetDataChunkCount(string dSource, int dType)
		{
			

			switch (dType)
			{
				//If binary version 1 we get the number of files contained
				case 1:
					using (BinaryReader breader = new BinaryReader(new FileStream(dSource, FileMode.Open)))
					{
						byte[] dCountAsBytes = new byte[4];
						breader.BaseStream.Seek(8, SeekOrigin.Begin);
						breader.Read(dCountAsBytes, 0, 4);
						int dCount = BitConverter.ToInt32(dCountAsBytes);
						return dCount;
					}
			}

			return 0;
		}

		private void DisplayVersion1FileInfo(int dCount)
		{
			//Function to read version 1 binary files and display each file name into a data view

			//Byte arrays - we need to go through the file and grab all the file names, as well as the size of the file's data
			byte[] bFileName = new byte[dCount];	//File name
			byte[] bDataLength = new byte[4]; //Length of file data
			int currentOffset = 12;

			using (BinaryReader breader = new BinaryReader(new FileStream(binFileLocation, FileMode.Open)))
			{
				for (int i = 0; i < dCount; i++)
				{

				}
			}
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			OpenBinaryFile();
		}

		private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
