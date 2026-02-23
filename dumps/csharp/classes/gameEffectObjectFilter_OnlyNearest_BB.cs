using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectFilter_OnlyNearest_BB : gameEffectObjectFilter_OnlyNearest
	{
		private gameEffectInputParameter_Int _parameter;

		[Ordinal(1)] 
		[RED("parameter")] 
		public gameEffectInputParameter_Int Parameter
		{
			get => GetProperty(ref _parameter);
			set => SetProperty(ref _parameter, value);
		}

		public gameEffectObjectFilter_OnlyNearest_BB(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
