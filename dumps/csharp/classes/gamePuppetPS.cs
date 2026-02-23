using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePuppetPS : gameObjectPS
	{
		private CName _gender;
		private CBool _wasQuickHacked;
		private CBool _hasQuickHackBegunUpload;
		private CBool _hasAlternativeName;
		private CBool _isCrouch;
		private CBool _allowVehicleCollisionRagdoll;

		[Ordinal(0)] 
		[RED("gender")] 
		public CName Gender
		{
			get => GetProperty(ref _gender);
			set => SetProperty(ref _gender, value);
		}

		[Ordinal(1)] 
		[RED("wasQuickHacked")] 
		public CBool WasQuickHacked
		{
			get => GetProperty(ref _wasQuickHacked);
			set => SetProperty(ref _wasQuickHacked, value);
		}

		[Ordinal(2)] 
		[RED("hasQuickHackBegunUpload")] 
		public CBool HasQuickHackBegunUpload
		{
			get => GetProperty(ref _hasQuickHackBegunUpload);
			set => SetProperty(ref _hasQuickHackBegunUpload, value);
		}

		[Ordinal(3)] 
		[RED("hasAlternativeName")] 
		public CBool HasAlternativeName
		{
			get => GetProperty(ref _hasAlternativeName);
			set => SetProperty(ref _hasAlternativeName, value);
		}

		[Ordinal(4)] 
		[RED("isCrouch")] 
		public CBool IsCrouch
		{
			get => GetProperty(ref _isCrouch);
			set => SetProperty(ref _isCrouch, value);
		}

		[Ordinal(5)] 
		[RED("allowVehicleCollisionRagdoll")] 
		public CBool AllowVehicleCollisionRagdoll
		{
			get => GetProperty(ref _allowVehicleCollisionRagdoll);
			set => SetProperty(ref _allowVehicleCollisionRagdoll, value);
		}

		public gamePuppetPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
