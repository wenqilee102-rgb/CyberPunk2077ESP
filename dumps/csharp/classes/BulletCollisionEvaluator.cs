using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BulletCollisionEvaluator : gameprojectileScriptCollisionEvaluator
	{
		private wCHandle<gameObject> _user;
		private CBool _hasStopped;
		private Vector4 _stoppedPosition;
		private gameprojectileWeaponParams _weaponParams;
		private CBool _isExplodingBullet;
		private CBool _isSmartBullet;

		[Ordinal(0)] 
		[RED("user")] 
		public wCHandle<gameObject> User
		{
			get => GetProperty(ref _user);
			set => SetProperty(ref _user, value);
		}

		[Ordinal(1)] 
		[RED("hasStopped")] 
		public CBool HasStopped
		{
			get => GetProperty(ref _hasStopped);
			set => SetProperty(ref _hasStopped, value);
		}

		[Ordinal(2)] 
		[RED("stoppedPosition")] 
		public Vector4 StoppedPosition
		{
			get => GetProperty(ref _stoppedPosition);
			set => SetProperty(ref _stoppedPosition, value);
		}

		[Ordinal(3)] 
		[RED("weaponParams")] 
		public gameprojectileWeaponParams WeaponParams
		{
			get => GetProperty(ref _weaponParams);
			set => SetProperty(ref _weaponParams, value);
		}

		[Ordinal(4)] 
		[RED("isExplodingBullet")] 
		public CBool IsExplodingBullet
		{
			get => GetProperty(ref _isExplodingBullet);
			set => SetProperty(ref _isExplodingBullet, value);
		}

		[Ordinal(5)] 
		[RED("isSmartBullet")] 
		public CBool IsSmartBullet
		{
			get => GetProperty(ref _isSmartBullet);
			set => SetProperty(ref _isSmartBullet, value);
		}

		public BulletCollisionEvaluator(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
