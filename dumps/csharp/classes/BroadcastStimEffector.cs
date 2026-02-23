using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BroadcastStimEffector : gameContinuousEffector
	{
		private CEnum<gamedataStimType> _stimType;
		private CFloat _radius;

		[Ordinal(0)] 
		[RED("stimType")] 
		public CEnum<gamedataStimType> StimType
		{
			get => GetProperty(ref _stimType);
			set => SetProperty(ref _stimType, value);
		}

		[Ordinal(1)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		public BroadcastStimEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
