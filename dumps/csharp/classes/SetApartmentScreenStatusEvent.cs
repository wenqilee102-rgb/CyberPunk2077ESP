using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetApartmentScreenStatusEvent : redEvent
	{
		private CEnum<ERentStatus> _rentStatus;

		[Ordinal(0)] 
		[RED("rentStatus")] 
		public CEnum<ERentStatus> RentStatus
		{
			get => GetProperty(ref _rentStatus);
			set => SetProperty(ref _rentStatus, value);
		}

		public SetApartmentScreenStatusEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
