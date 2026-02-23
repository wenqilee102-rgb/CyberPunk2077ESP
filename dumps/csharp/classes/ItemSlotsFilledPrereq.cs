using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemSlotsFilledPrereq : gameIScriptablePrereq
	{
		private CArray<CEnum<gamedataEquipmentArea>> _equipAreas;

		[Ordinal(0)] 
		[RED("equipAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> EquipAreas
		{
			get => GetProperty(ref _equipAreas);
			set => SetProperty(ref _equipAreas, value);
		}

		public ItemSlotsFilledPrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
