using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MarketingConsentPopupData : inkGameNotificationData
	{
		private CEnum<inkMarketingConsentPopupType> _type;

		[Ordinal(7)] 
		[RED("type")] 
		public CEnum<inkMarketingConsentPopupType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		public MarketingConsentPopupData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
