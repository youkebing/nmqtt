/* 
 * nMQTT, a .Net MQTT v3 client implementation.
 * http://code.google.com/p/nmqtt
 * 
 * Copyright (c) 2009 Mark Allanson (mark@markallanson.net)
 *
 * Licensed under the MIT License. You may not use this file except 
 * in compliance with the License. You may obtain a copy of the License at
 *
 *     http://www.opensource.org/licenses/mit-license.php
*/

using System;
using System.Windows.Forms;
using nMqtt.SampleApp.ViewModels;

namespace nMqtt.SampleApp.Views
{
	public class Shell : Form
	{
		private ShellViewModel viewModel;
		
		public Shell (ShellViewModel viewModel)
		{
			this.viewModel = viewModel;
			
			InitializeComponents();
		}
		
		private void InitializeComponents()
		{
			this.Text = viewModel.WindowTitle;
		}
	}
}