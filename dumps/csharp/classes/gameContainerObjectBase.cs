using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameContainerObjectBase : gameLootContainerBase
	{
		private CBool _giveHandicapAmmo;
		private TweakDBID _lockedByKey;

		[Ordinal(47)] 
		[RED("giveHandicapAmmo")] 
		public CBool GiveHandicapAmmo
		{
			get => GetProperty(ref _giveHandicapAmmo);
			set => SetProperty(ref _giveHandicapAmmo, value);
		}

		[Ordinal(48)] 
		[RED("lockedByKey")] 
		public TweakDBID LockedByKey
		{
			get => GetProperty(ref _lockedByKey);
			set => SetProperty(ref _lockedByKey, value);
		}

		public gameContainerObjectBase(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
