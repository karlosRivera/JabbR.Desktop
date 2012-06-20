using System;
using Eto;
using System.Xml;
using Eto.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JabbR.Eto.Model.JabbR;
using JabbR.Eto.Interface;

namespace JabbR.Eto.Model
{
	public class ChannelEventArgs : EventArgs
	{
		public Channel Channel { get; private set; }
		
		public ChannelEventArgs(Channel channel)
		{
			this.Channel = channel;
		}
	}

}

