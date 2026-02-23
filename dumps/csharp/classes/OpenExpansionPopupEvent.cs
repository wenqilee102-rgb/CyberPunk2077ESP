using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OpenExpansionPopupEvent : redEvent
	{
		private CEnum<ExpansionPopupType> _type;
		private CEnum<ExpansionStatus> _state;
		private CBool _forcibly;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<ExpansionPopupType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<ExpansionStatus> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(2)] 
		[RED("forcibly")] 
		public CBool Forcibly
		{
			get => GetProperty(ref _forcibly);
			set => SetProperty(ref _forcibly, value);
		}

		public OpenExpansionPopupEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
