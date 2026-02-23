using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyStatusEffectDurationEffector : gameEffector
	{
		private CHandle<OnStatusEffectAppliedListener> _statusEffectListener;
		private CArray<CName> _tags;
		private CFloat _change;
		private CBool _isPercentage;
		private CBool _listenConstantly;
		private CBool _canGoOverInitialDuration;
		private ScriptGameInstance _gameInstance;

		[Ordinal(0)] 
		[RED("statusEffectListener")] 
		public CHandle<OnStatusEffectAppliedListener> StatusEffectListener
		{
			get => GetProperty(ref _statusEffectListener);
			set => SetProperty(ref _statusEffectListener, value);
		}

		[Ordinal(1)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get => GetProperty(ref _tags);
			set => SetProperty(ref _tags, value);
		}

		[Ordinal(2)] 
		[RED("change")] 
		public CFloat Change
		{
			get => GetProperty(ref _change);
			set => SetProperty(ref _change, value);
		}

		[Ordinal(3)] 
		[RED("isPercentage")] 
		public CBool IsPercentage
		{
			get => GetProperty(ref _isPercentage);
			set => SetProperty(ref _isPercentage, value);
		}

		[Ordinal(4)] 
		[RED("listenConstantly")] 
		public CBool ListenConstantly
		{
			get => GetProperty(ref _listenConstantly);
			set => SetProperty(ref _listenConstantly, value);
		}

		[Ordinal(5)] 
		[RED("canGoOverInitialDuration")] 
		public CBool CanGoOverInitialDuration
		{
			get => GetProperty(ref _canGoOverInitialDuration);
			set => SetProperty(ref _canGoOverInitialDuration, value);
		}

		[Ordinal(6)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		public ModifyStatusEffectDurationEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
