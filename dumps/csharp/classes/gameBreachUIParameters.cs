using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameBreachUIParameters : IScriptable
	{
		private CEnum<gameBreachUITrackingChange> _trackingChange;
		private CBool _tracking;
		private CBool _visible;
		private CBool _almostTimeout;
		private Vector2 _position;
		private CFloat _radius;
		private CFloat _distance;
		private CFloat _health;
		private CFloat _maxHealth;

		[Ordinal(0)] 
		[RED("trackingChange")] 
		public CEnum<gameBreachUITrackingChange> TrackingChange
		{
			get => GetProperty(ref _trackingChange);
			set => SetProperty(ref _trackingChange, value);
		}

		[Ordinal(1)] 
		[RED("tracking")] 
		public CBool Tracking
		{
			get => GetProperty(ref _tracking);
			set => SetProperty(ref _tracking, value);
		}

		[Ordinal(2)] 
		[RED("visible")] 
		public CBool Visible
		{
			get => GetProperty(ref _visible);
			set => SetProperty(ref _visible, value);
		}

		[Ordinal(3)] 
		[RED("almostTimeout")] 
		public CBool AlmostTimeout
		{
			get => GetProperty(ref _almostTimeout);
			set => SetProperty(ref _almostTimeout, value);
		}

		[Ordinal(4)] 
		[RED("position")] 
		public Vector2 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(5)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(6)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetProperty(ref _distance);
			set => SetProperty(ref _distance, value);
		}

		[Ordinal(7)] 
		[RED("health")] 
		public CFloat Health
		{
			get => GetProperty(ref _health);
			set => SetProperty(ref _health, value);
		}

		[Ordinal(8)] 
		[RED("maxHealth")] 
		public CFloat MaxHealth
		{
			get => GetProperty(ref _maxHealth);
			set => SetProperty(ref _maxHealth, value);
		}

		public gameBreachUIParameters(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
