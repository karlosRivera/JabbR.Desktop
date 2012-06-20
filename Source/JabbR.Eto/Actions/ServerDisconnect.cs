using System;
using Eto.Forms;
using JabbR.Eto.Interface;
using JabbR.Eto.Model;

namespace JabbR.Eto.Actions
{
	public class ServerDisconnect : ButtonAction
	{
		public const string ActionID = "ServerDisconnect";
		Channels channels;
		Configuration config;
		
		public ServerDisconnect (Channels channels, Configuration config)
		{
			this.channels = channels;
			this.config = config;
			this.ID = ActionID;
			this.MenuText = "Disconnect";
			
		}
		
		public override bool Enabled {
			get {
				return base.Enabled && channels.SelectedServer != null && channels.SelectedServer.IsConnected;
			}
			set {
				base.Enabled = value;
			}
		}
		
		protected override void OnActivated (EventArgs e)
		{
			base.OnActivated (e);
			var server = channels.SelectedServer;
			if (server != null && server.IsConnected) {
				server.Disconnect ();
			}
		}
	}
}

