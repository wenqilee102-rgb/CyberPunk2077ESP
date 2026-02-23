using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EquipAnimationUpdateData : IScriptable
	{
		private CEnum<gamedataEquipmentArea> _equipArea;
		private CBool _isEquip;

		[Ordinal(0)] 
		[RED("equipArea")] 
		public CEnum<gamedataEquipmentArea> EquipArea
		{
			get => GetProperty(ref _equipArea);
			set => SetProperty(ref _equipArea, value);
		}

		[Ordinal(1)] 
		[RED("isEquip")] 
		public CBool IsEquip
		{
			get => GetProperty(ref _isEquip);
			set => SetProperty(ref _isEquip, value);
		}

		public EquipAnimationUpdateData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
