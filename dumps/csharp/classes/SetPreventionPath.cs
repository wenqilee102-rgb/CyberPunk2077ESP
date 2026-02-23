using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetPreventionPath : gameScriptableSystemRequest
	{
		private CEnum<EVehicleSpawnBlockSide> _blockSpawnFrom;
		private CBool _resetToDefault;
		private CName _source;

		[Ordinal(0)] 
		[RED("blockSpawnFrom")] 
		public CEnum<EVehicleSpawnBlockSide> BlockSpawnFrom
		{
			get => GetProperty(ref _blockSpawnFrom);
			set => SetProperty(ref _blockSpawnFrom, value);
		}

		[Ordinal(1)] 
		[RED("resetToDefault")] 
		public CBool ResetToDefault
		{
			get => GetProperty(ref _resetToDefault);
			set => SetProperty(ref _resetToDefault, value);
		}

		[Ordinal(2)] 
		[RED("source")] 
		public CName Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		public SetPreventionPath(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
