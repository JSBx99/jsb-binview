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

			}




				DisplayDataChunkList(01);
		}
		
		private void DisplayDataChunkList(int bVersion)
		{

		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			OpenBinaryFile();
		}
	}
}
