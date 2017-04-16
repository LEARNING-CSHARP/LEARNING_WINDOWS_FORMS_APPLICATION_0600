namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, System.EventArgs e)
		{
			// currentButton:
			// دکمه جاری که بر روی آن کلیک کرده‌ایم

			// Solution (1)
			//System.Windows.Forms.Button
			//	currentButton = (System.Windows.Forms.Button)sender;
			// /Solution (1)

			// Solution (2)
			//System.Windows.Forms.Button currentButton = null;

			//if (sender is System.Windows.Forms.Button)
			//{
			//	currentButton =
			//		(System.Windows.Forms.Button)sender;
			//}
			//else
			//{
			//	System.Windows.Forms.MessageBox.Show("Note: [sender] is not Button!");

			//	return;
			//}
			// /Solution (2)

			// Solution (3)
			System.Windows.Forms.Button
				currentButton = sender as System.Windows.Forms.Button;

			if (currentButton == null)
			{
				System.Windows.Forms.MessageBox.Show("Note: [sender] is not Button!");

				return;
			}
			// /Solution (3)

			switch (currentButton.Name)
			{
				case "button1":
				{
					System.Windows.Forms.MessageBox.Show("Hello, World (1)!");
					break;
				}

				case "button2":
				{
					System.Windows.Forms.MessageBox.Show("Hello, World (2)!");
					break;
				}

				case "button3":
				{
					System.Windows.Forms.MessageBox.Show("Hello, World (3)!");
					break;
				}

				case "button4":
				{
					System.Windows.Forms.MessageBox.Show("Hello, World (4)!");
					break;
				}

				case "button5":
				{
					System.Windows.Forms.MessageBox.Show("Hello, World (5)!");
					break;
				}
			}
		}
	}
}
