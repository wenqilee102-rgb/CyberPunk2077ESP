using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleBlockSceneInteractions : gameScriptableSystemRequest
	{
		private CBool _block;

		[Ordinal(0)] 
		[RED("block")] 
		public CBool Block
		{
			get => GetProperty(ref _block);
			set => SetProperty(ref _block, value);
		}

		public ToggleBlockSceneInteractions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
