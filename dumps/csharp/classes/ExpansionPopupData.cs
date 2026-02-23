using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExpansionPopupData : inkGameNotificationData
	{
		private CEnum<ExpansionPopupType> _type;
		private CEnum<ExpansionStatus> _state;

		[Ordinal(7)] 
		[RED("type")] 
		public CEnum<ExpansionPopupType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(8)] 
		[RED("state")] 
		public CEnum<ExpansionStatus> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		public ExpansionPopupData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
