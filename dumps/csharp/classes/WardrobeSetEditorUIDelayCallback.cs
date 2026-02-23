using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WardrobeSetEditorUIDelayCallback : gameDelaySystemScriptedDelayCallbackWrapper
	{
		private wCHandle<WardrobeSetEditorUIController> _owner;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<WardrobeSetEditorUIController> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		public WardrobeSetEditorUIDelayCallback(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
