using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UnderwearEquipFailsafeEvent : redEvent
	{
		private CBool _bottom;

		[Ordinal(0)] 
		[RED("bottom")] 
		public CBool Bottom
		{
			get => GetProperty(ref _bottom);
			set => SetProperty(ref _bottom, value);
		}

		public UnderwearEquipFailsafeEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
