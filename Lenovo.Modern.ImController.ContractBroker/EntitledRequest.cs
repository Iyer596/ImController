﻿using System;
using System.Xml.Serialization;

namespace Lenovo.Modern.ImController.ContractBroker
{
	// Token: 0x02000003 RID: 3
	[XmlRoot(ElementName = "EntitledRequest", Namespace = "")]
	public sealed class EntitledRequest
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002185 File Offset: 0x00000385
		// (set) Token: 0x06000004 RID: 4 RVA: 0x0000218D File Offset: 0x0000038D
		[XmlElement("DeviceID")]
		public string DeviceID { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002196 File Offset: 0x00000396
		// (set) Token: 0x06000006 RID: 6 RVA: 0x0000219E File Offset: 0x0000039E
		[XmlElement("AppName")]
		public string AppName { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000021A7 File Offset: 0x000003A7
		// (set) Token: 0x06000008 RID: 8 RVA: 0x000021AF File Offset: 0x000003AF
		[XmlElement("AppVersion")]
		public string AppVersion { get; set; }
	}
}
