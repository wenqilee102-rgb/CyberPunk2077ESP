using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSSlotVisualInfo : CVariable
	{
		private CEnum<gamedataEquipmentArea> _areaType;
		private CBool _isHidden;
		private gameItemID _visualItem;

		[Ordinal(0)] 
		[RED("areaType")] 
		public CEnum<gamedataEquipmentArea> AreaType
		{
			get => GetProperty(ref _areaType);
			set => SetProperty(ref _areaType, value);
		}

		[Ordinal(1)] 
		[RED("isHidden")] 
		public CBool IsHidden
		{
			get => GetProperty(ref _isHidden);
			set => SetProperty(ref _isHidden, value);
		}

		[Ordinal(2)] 
		[RED("visualItem")] 
		public gameItemID VisualItem
		{
			get => GetProperty(ref _visualItem);
			set => SetProperty(ref _visualItem, value);
		}

		public gameSSlotVisualInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
