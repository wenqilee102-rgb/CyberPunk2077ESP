using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameOnCarHitPlayer : redEvent
	{
		private Vector4 _hitDirection;
		private Vector4 _seperationImpulse;
		private entEntityID _carId;

		[Ordinal(0)] 
		[RED("hitDirection")] 
		public Vector4 HitDirection
		{
			get => GetProperty(ref _hitDirection);
			set => SetProperty(ref _hitDirection, value);
		}

		[Ordinal(1)] 
		[RED("seperationImpulse")] 
		public Vector4 SeperationImpulse
		{
			get => GetProperty(ref _seperationImpulse);
			set => SetProperty(ref _seperationImpulse, value);
		}

		[Ordinal(2)] 
		[RED("carId")] 
		public entEntityID CarId
		{
			get => GetProperty(ref _carId);
			set => SetProperty(ref _carId, value);
		}

		public gameOnCarHitPlayer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
