using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DelayedSelect : gameDelaySystemScriptedDelayCallbackWrapper
	{
		private wCHandle<CraftingMainLogicController> _controller;
		private CUInt32 _index;

		[Ordinal(0)] 
		[RED("controller")] 
		public wCHandle<CraftingMainLogicController> Controller
		{
			get => GetProperty(ref _controller);
			set => SetProperty(ref _controller, value);
		}

		[Ordinal(1)] 
		[RED("index")] 
		public CUInt32 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		public DelayedSelect(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
