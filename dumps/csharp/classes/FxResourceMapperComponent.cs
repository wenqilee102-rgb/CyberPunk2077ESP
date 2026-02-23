using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FxResourceMapperComponent : gameScriptableComponent
	{
		private CArray<CHandle<AreaEffectData>> _areaEffectData;
		private CFloat _investigationSlotOffsetMultiplier;
		private CArray<CHandle<AreaEffectTargetData>> _areaEffectInFocusMode;
		private CArray<CHandle<OptionalAreaEffectData>> _optionalAreaEffectData;
		private CBool _dEBUG_copiedDataFromEntity;
		private CBool _dEBUG_copiedDataFromFXStruct;
		private CBool _isInitialized;

		[Ordinal(5)] 
		[RED("areaEffectData")] 
		public CArray<CHandle<AreaEffectData>> AreaEffectData
		{
			get => GetProperty(ref _areaEffectData);
			set => SetProperty(ref _areaEffectData, value);
		}

		[Ordinal(6)] 
		[RED("investigationSlotOffsetMultiplier")] 
		public CFloat InvestigationSlotOffsetMultiplier
		{
			get => GetProperty(ref _investigationSlotOffsetMultiplier);
			set => SetProperty(ref _investigationSlotOffsetMultiplier, value);
		}

		[Ordinal(7)] 
		[RED("areaEffectInFocusMode")] 
		public CArray<CHandle<AreaEffectTargetData>> AreaEffectInFocusMode
		{
			get => GetProperty(ref _areaEffectInFocusMode);
			set => SetProperty(ref _areaEffectInFocusMode, value);
		}

		[Ordinal(8)] 
		[RED("optionalAreaEffectData")] 
		public CArray<CHandle<OptionalAreaEffectData>> OptionalAreaEffectData
		{
			get => GetProperty(ref _optionalAreaEffectData);
			set => SetProperty(ref _optionalAreaEffectData, value);
		}

		[Ordinal(9)] 
		[RED("DEBUG_copiedDataFromEntity")] 
		public CBool DEBUG_copiedDataFromEntity
		{
			get => GetProperty(ref _dEBUG_copiedDataFromEntity);
			set => SetProperty(ref _dEBUG_copiedDataFromEntity, value);
		}

		[Ordinal(10)] 
		[RED("DEBUG_copiedDataFromFXStruct")] 
		public CBool DEBUG_copiedDataFromFXStruct
		{
			get => GetProperty(ref _dEBUG_copiedDataFromFXStruct);
			set => SetProperty(ref _dEBUG_copiedDataFromFXStruct, value);
		}

		[Ordinal(11)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get => GetProperty(ref _isInitialized);
			set => SetProperty(ref _isInitialized, value);
		}

		public FxResourceMapperComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
