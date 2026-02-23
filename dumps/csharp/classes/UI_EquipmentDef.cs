using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_EquipmentDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _itemEquipped;
		private gamebbScriptID_Variant _lastModifiedArea;
		private gamebbScriptID_Int32 _areaChanged;
		private gamebbScriptID_Int32 _areaChangedSlotIndex;
		private gamebbScriptID_Bool _equipmentInProgress;

		[Ordinal(0)] 
		[RED("itemEquipped")] 
		public gamebbScriptID_Variant ItemEquipped
		{
			get => GetProperty(ref _itemEquipped);
			set => SetProperty(ref _itemEquipped, value);
		}

		[Ordinal(1)] 
		[RED("lastModifiedArea")] 
		public gamebbScriptID_Variant LastModifiedArea
		{
			get => GetProperty(ref _lastModifiedArea);
			set => SetProperty(ref _lastModifiedArea, value);
		}

		[Ordinal(2)] 
		[RED("areaChanged")] 
		public gamebbScriptID_Int32 AreaChanged
		{
			get => GetProperty(ref _areaChanged);
			set => SetProperty(ref _areaChanged, value);
		}

		[Ordinal(3)] 
		[RED("areaChangedSlotIndex")] 
		public gamebbScriptID_Int32 AreaChangedSlotIndex
		{
			get => GetProperty(ref _areaChangedSlotIndex);
			set => SetProperty(ref _areaChangedSlotIndex, value);
		}

		[Ordinal(4)] 
		[RED("EquipmentInProgress")] 
		public gamebbScriptID_Bool EquipmentInProgress
		{
			get => GetProperty(ref _equipmentInProgress);
			set => SetProperty(ref _equipmentInProgress, value);
		}

		public UI_EquipmentDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
