using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProjectileHitAoEData : CVariable
	{
		private wCHandle<gameObject> _source;
		private wCHandle<gameObject> _instigator;
		private Vector4 _position;
		private CFloat _radius;
		private CFloat _duration;
		private CHandle<gamedataAttack_Record> _attackRecord;
		private wCHandle<gameweaponObject> _weapon;
		private CBool _disableVfx;
		private CBool _enableImpulseFalloff;
		private CFloat _impulseFalloffFactor;

		[Ordinal(0)] 
		[RED("source")] 
		public wCHandle<gameObject> Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		[Ordinal(1)] 
		[RED("instigator")] 
		public wCHandle<gameObject> Instigator
		{
			get => GetProperty(ref _instigator);
			set => SetProperty(ref _instigator, value);
		}

		[Ordinal(2)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(3)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(4)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(5)] 
		[RED("attackRecord")] 
		public CHandle<gamedataAttack_Record> AttackRecord
		{
			get => GetProperty(ref _attackRecord);
			set => SetProperty(ref _attackRecord, value);
		}

		[Ordinal(6)] 
		[RED("weapon")] 
		public wCHandle<gameweaponObject> Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}

		[Ordinal(7)] 
		[RED("disableVfx")] 
		public CBool DisableVfx
		{
			get => GetProperty(ref _disableVfx);
			set => SetProperty(ref _disableVfx, value);
		}

		[Ordinal(8)] 
		[RED("enableImpulseFalloff")] 
		public CBool EnableImpulseFalloff
		{
			get => GetProperty(ref _enableImpulseFalloff);
			set => SetProperty(ref _enableImpulseFalloff, value);
		}

		[Ordinal(9)] 
		[RED("impulseFalloffFactor")] 
		public CFloat ImpulseFalloffFactor
		{
			get => GetProperty(ref _impulseFalloffFactor);
			set => SetProperty(ref _impulseFalloffFactor, value);
		}

		public ProjectileHitAoEData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
