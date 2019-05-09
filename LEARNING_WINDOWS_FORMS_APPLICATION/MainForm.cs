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
			// **************************************************
			// Note: Wrong Usage!
			// **************************************************
			//switch(sender)
			//{
			//	case button1:
			//	{
			//		System.Windows.Forms.MessageBox.Show("Hello, World (1)!");
			//		break;
			//	}
			//}
			// **************************************************

			// **************************************************
			// Note: Wrong Usage!
			// **************************************************
			//switch(sender.Name)
			//{
			//	case "button1":
			//	{
			//		System.Windows.Forms.MessageBox.Show("Hello, World (1)!");
			//		break;
			//	}
			//}
			// **************************************************

			// currentButton:
			// دکمه جاری که بر روی آن کلیک کرده‌ایم

			// Solution (1)
			//System.Windows.Forms.Button
			//	currentButton = (System.Windows.Forms.Button)sender;
			// /Solution (1)

			// Solution (2)
			//if (sender is System.Windows.Forms.Button)
			//{
			//	System.Windows.Forms.Button currentButton = (System.Windows.Forms.Button)sender;

			//	switch (currentButton.Name)
			//	{
			//		case "button1":
			//		{
			//			System.Windows.Forms.MessageBox.Show("Hello, World (1)!");
			//			break;
			//		}
			//	}
			//}
			//else
			//{
			//	System.Windows.Forms.MessageBox.Show("Note: [sender] is not a Button!");
			//}
			// /Solution (2)

			// Solution (3)
			System.Windows.Forms.Button
				currentButton = sender as System.Windows.Forms.Button;

			if (currentButton != null)
			{
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
			else
			{
				System.Windows.Forms.MessageBox.Show("Note: [sender] is not Button!");
			}
			// /Solution (3)
		}
	}
}
