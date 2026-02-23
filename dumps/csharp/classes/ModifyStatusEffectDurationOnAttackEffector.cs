using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyStatusEffectDurationOnAttackEffector : ModifyAttackEffector
	{
		private CArray<CName> _tags;
		private CFloat _change;
		private CBool _isPercentage;
		private CBool _listenConstantly;
		private ScriptGameInstance _gameInstance;

		[Ordinal(0)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get => GetProperty(ref _tags);
			set => SetProperty(ref _tags, value);
		}

		[Ordinal(1)] 
		[RED("change")] 
		public CFloat Change
		{
			get => GetProperty(ref _change);
			set => SetProperty(ref _change, value);
		}

		[Ordinal(2)] 
		[RED("isPercentage")] 
		public CBool IsPercentage
		{
			get => GetProperty(ref _isPercentage);
			set => SetProperty(ref _isPercentage, value);
		}

		[Ordinal(3)] 
		[RED("listenConstantly")] 
		public CBool ListenConstantly
		{
			get => GetProperty(ref _listenConstantly);
			set => SetProperty(ref _listenConstantly, value);
		}

		[Ordinal(4)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		public ModifyStatusEffectDurationOnAttackEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
