using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class YaibaShowroomConnectionPage : gameuiWidgetGameController
	{
		private CName _connectionFact;
		private inkWidgetReference _connectionButton;

		[Ordinal(2)] 
		[RED("connectionFact")] 
		public CName ConnectionFact
		{
			get => GetProperty(ref _connectionFact);
			set => SetProperty(ref _connectionFact, value);
		}

		[Ordinal(3)] 
		[RED("connectionButton")] 
		public inkWidgetReference ConnectionButton
		{
			get => GetProperty(ref _connectionButton);
			set => SetProperty(ref _connectionButton, value);
		}

		public YaibaShowroomConnectionPage(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
