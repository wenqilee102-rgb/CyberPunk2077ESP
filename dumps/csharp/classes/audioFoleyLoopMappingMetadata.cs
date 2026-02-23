using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioFoleyLoopMappingMetadata : audioAudioMetadata
	{
		private CArray<audioAppearanceToFoleyLoopMetadata> _loopsPerAppearance;
		private CArray<audioVisualTagToFoleyLoopMetadata> _loopsPerVisualTag;

		[Ordinal(1)] 
		[RED("loopsPerAppearance")] 
		public CArray<audioAppearanceToFoleyLoopMetadata> LoopsPerAppearance
		{
			get => GetProperty(ref _loopsPerAppearance);
			set => SetProperty(ref _loopsPerAppearance, value);
		}

		[Ordinal(2)] 
		[RED("loopsPerVisualTag")] 
		public CArray<audioVisualTagToFoleyLoopMetadata> LoopsPerVisualTag
		{
			get => GetProperty(ref _loopsPerVisualTag);
			set => SetProperty(ref _loopsPerVisualTag, value);
		}

		public audioFoleyLoopMappingMetadata(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
