using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiNewPhoneRelatedGameController : gameuiWidgetGameController
	{
		private CBool _isNewPhoneEnabled;

		[Ordinal(2)] 
		[RED("isNewPhoneEnabled")] 
		public CBool IsNewPhoneEnabled
		{
			get => GetProperty(ref _isNewPhoneEnabled);
			set => SetProperty(ref _isNewPhoneEnabled, value);
		}

		public gameuiNewPhoneRelatedGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
