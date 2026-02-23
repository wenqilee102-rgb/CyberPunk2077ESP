using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entImpactPointData : CVariable
	{
		private WorldPosition _worldPosition;
		private Vector4 _worldNormal;
		private CFloat _forceMagnitude;
		private CFloat _impulseMagnitude;
		private CFloat _maxForceMagnitude;
		private CFloat _maxImpulseMagnitude;

		[Ordinal(0)] 
		[RED("worldPosition")] 
		public WorldPosition WorldPosition
		{
			get => GetProperty(ref _worldPosition);
			set => SetProperty(ref _worldPosition, value);
		}

		[Ordinal(1)] 
		[RED("worldNormal")] 
		public Vector4 WorldNormal
		{
			get => GetProperty(ref _worldNormal);
			set => SetProperty(ref _worldNormal, value);
		}

		[Ordinal(2)] 
		[RED("forceMagnitude")] 
		public CFloat ForceMagnitude
		{
			get => GetProperty(ref _forceMagnitude);
			set => SetProperty(ref _forceMagnitude, value);
		}

		[Ordinal(3)] 
		[RED("impulseMagnitude")] 
		public CFloat ImpulseMagnitude
		{
			get => GetProperty(ref _impulseMagnitude);
			set => SetProperty(ref _impulseMagnitude, value);
		}

		[Ordinal(4)] 
		[RED("maxForceMagnitude")] 
		public CFloat MaxForceMagnitude
		{
			get => GetProperty(ref _maxForceMagnitude);
			set => SetProperty(ref _maxForceMagnitude, value);
		}

		[Ordinal(5)] 
		[RED("maxImpulseMagnitude")] 
		public CFloat MaxImpulseMagnitude
		{
			get => GetProperty(ref _maxImpulseMagnitude);
			set => SetProperty(ref _maxImpulseMagnitude, value);
		}

		public entImpactPointData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
