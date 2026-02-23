using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entRagdollBodyPartWaterImpactEvent : redEvent
	{
		private Vector4 _worldPosition;
		private Vector4 _linearVelocity;
		private CFloat _depthBelowSurface;
		private CBool _isTorso;

		[Ordinal(0)] 
		[RED("worldPosition")] 
		public Vector4 WorldPosition
		{
			get => GetProperty(ref _worldPosition);
			set => SetProperty(ref _worldPosition, value);
		}

		[Ordinal(1)] 
		[RED("linearVelocity")] 
		public Vector4 LinearVelocity
		{
			get => GetProperty(ref _linearVelocity);
			set => SetProperty(ref _linearVelocity, value);
		}

		[Ordinal(2)] 
		[RED("depthBelowSurface")] 
		public CFloat DepthBelowSurface
		{
			get => GetProperty(ref _depthBelowSurface);
			set => SetProperty(ref _depthBelowSurface, value);
		}

		[Ordinal(3)] 
		[RED("isTorso")] 
		public CBool IsTorso
		{
			get => GetProperty(ref _isTorso);
			set => SetProperty(ref _isTorso, value);
		}

		public entRagdollBodyPartWaterImpactEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
