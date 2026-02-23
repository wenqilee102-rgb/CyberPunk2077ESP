using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameLootContainerBasePS : gameObjectPS
	{
		private CBool _markAsQuest;
		private CBool _isDisabled;
		private CBool _isLocked;
		private CBool _shouldHideLockedUI;
		private CBool _started;

		[Ordinal(0)] 
		[RED("markAsQuest")] 
		public CBool MarkAsQuest
		{
			get => GetProperty(ref _markAsQuest);
			set => SetProperty(ref _markAsQuest, value);
		}

		[Ordinal(1)] 
		[RED("isDisabled")] 
		public CBool IsDisabled
		{
			get => GetProperty(ref _isDisabled);
			set => SetProperty(ref _isDisabled, value);
		}

		[Ordinal(2)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetProperty(ref _isLocked);
			set => SetProperty(ref _isLocked, value);
		}

		[Ordinal(3)] 
		[RED("shouldHideLockedUI")] 
		public CBool ShouldHideLockedUI
		{
			get => GetProperty(ref _shouldHideLockedUI);
			set => SetProperty(ref _shouldHideLockedUI, value);
		}

		[Ordinal(4)] 
		[RED("started")] 
		public CBool Started
		{
			get => GetProperty(ref _started);
			set => SetProperty(ref _started, value);
		}

		public gameLootContainerBasePS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
