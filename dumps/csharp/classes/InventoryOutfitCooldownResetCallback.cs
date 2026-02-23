using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryOutfitCooldownResetCallback : gameDelaySystemScriptedDelayCallbackWrapper
	{
		private wCHandle<InventoryItemModeLogicController> _controller;

		[Ordinal(0)] 
		[RED("controller")] 
		public wCHandle<InventoryItemModeLogicController> Controller
		{
			get => GetProperty(ref _controller);
			set => SetProperty(ref _controller, value);
		}

		public InventoryOutfitCooldownResetCallback(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
