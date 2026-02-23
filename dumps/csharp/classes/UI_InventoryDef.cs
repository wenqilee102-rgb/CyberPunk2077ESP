using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_InventoryDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _itemAdded;
		private gamebbScriptID_Variant _itemRemoved;
		private gamebbScriptID_Variant _itemQuantityChanged;

		[Ordinal(0)] 
		[RED("itemAdded")] 
		public gamebbScriptID_Variant ItemAdded
		{
			get => GetProperty(ref _itemAdded);
			set => SetProperty(ref _itemAdded, value);
		}

		[Ordinal(1)] 
		[RED("itemRemoved")] 
		public gamebbScriptID_Variant ItemRemoved
		{
			get => GetProperty(ref _itemRemoved);
			set => SetProperty(ref _itemRemoved, value);
		}

		[Ordinal(2)] 
		[RED("itemQuantityChanged")] 
		public gamebbScriptID_Variant ItemQuantityChanged
		{
			get => GetProperty(ref _itemQuantityChanged);
			set => SetProperty(ref _itemQuantityChanged, value);
		}

		public UI_InventoryDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
