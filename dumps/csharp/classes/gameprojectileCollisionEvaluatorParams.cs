using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileCollisionEvaluatorParams : IScriptable
	{
		private wCHandle<gameObject> _target;
		private CBool _isPiercableSurface;
		private CBool _isWaterSurface;
		private CBool _isAutoBounceSurface;
		private CFloat _angle;
		private CUInt32 _numBounces;
		private Vector4 _position;
		private CName _projectilePenetration;
		private CBool _isTechPiercing;
		private CBool _isDestructible;

		[Ordinal(0)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(1)] 
		[RED("isPiercableSurface")] 
		public CBool IsPiercableSurface
		{
			get => GetProperty(ref _isPiercableSurface);
			set => SetProperty(ref _isPiercableSurface, value);
		}

		[Ordinal(2)] 
		[RED("isWaterSurface")] 
		public CBool IsWaterSurface
		{
			get => GetProperty(ref _isWaterSurface);
			set => SetProperty(ref _isWaterSurface, value);
		}

		[Ordinal(3)] 
		[RED("isAutoBounceSurface")] 
		public CBool IsAutoBounceSurface
		{
			get => GetProperty(ref _isAutoBounceSurface);
			set => SetProperty(ref _isAutoBounceSurface, value);
		}

		[Ordinal(4)] 
		[RED("angle")] 
		public CFloat Angle
		{
			get => GetProperty(ref _angle);
			set => SetProperty(ref _angle, value);
		}

		[Ordinal(5)] 
		[RED("numBounces")] 
		public CUInt32 NumBounces
		{
			get => GetProperty(ref _numBounces);
			set => SetProperty(ref _numBounces, value);
		}

		[Ordinal(6)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(7)] 
		[RED("projectilePenetration")] 
		public CName ProjectilePenetration
		{
			get => GetProperty(ref _projectilePenetration);
			set => SetProperty(ref _projectilePenetration, value);
		}

		[Ordinal(8)] 
		[RED("isTechPiercing")] 
		public CBool IsTechPiercing
		{
			get => GetProperty(ref _isTechPiercing);
			set => SetProperty(ref _isTechPiercing, value);
		}

		[Ordinal(9)] 
		[RED("isDestructible")] 
		public CBool IsDestructible
		{
			get => GetProperty(ref _isDestructible);
			set => SetProperty(ref _isDestructible, value);
		}

		public gameprojectileCollisionEvaluatorParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
