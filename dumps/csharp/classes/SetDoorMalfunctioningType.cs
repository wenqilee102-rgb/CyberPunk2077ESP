using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetDoorMalfunctioningType : redEvent
	{
		private CEnum<EMalfunctioningType> _malfunctioningType;

		[Ordinal(0)] 
		[RED("malfunctioningType")] 
		public CEnum<EMalfunctioningType> MalfunctioningType
		{
			get => GetProperty(ref _malfunctioningType);
			set => SetProperty(ref _malfunctioningType, value);
		}

		public SetDoorMalfunctioningType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
