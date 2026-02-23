using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiForcePlayerCustomizationData : CVariable
	{
		private CEnum<gameuiCharacterCustomizationPart> _customizationPart;
		private CName _uiSlot;
		private CUInt32 _index;
		private CName _partUiSlot;
		private CUInt32 _partIndex;
		private CName _definitionUiSlot;
		private CName _definition;

		[Ordinal(0)] 
		[RED("customizationPart")] 
		public CEnum<gameuiCharacterCustomizationPart> CustomizationPart
		{
			get => GetProperty(ref _customizationPart);
			set => SetProperty(ref _customizationPart, value);
		}

		[Ordinal(1)] 
		[RED("uiSlot")] 
		public CName UiSlot
		{
			get => GetProperty(ref _uiSlot);
			set => SetProperty(ref _uiSlot, value);
		}

		[Ordinal(2)] 
		[RED("index")] 
		public CUInt32 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		[Ordinal(3)] 
		[RED("partUiSlot")] 
		public CName PartUiSlot
		{
			get => GetProperty(ref _partUiSlot);
			set => SetProperty(ref _partUiSlot, value);
		}

		[Ordinal(4)] 
		[RED("partIndex")] 
		public CUInt32 PartIndex
		{
			get => GetProperty(ref _partIndex);
			set => SetProperty(ref _partIndex, value);
		}

		[Ordinal(5)] 
		[RED("definitionUiSlot")] 
		public CName DefinitionUiSlot
		{
			get => GetProperty(ref _definitionUiSlot);
			set => SetProperty(ref _definitionUiSlot, value);
		}

		[Ordinal(6)] 
		[RED("definition")] 
		public CName Definition
		{
			get => GetProperty(ref _definition);
			set => SetProperty(ref _definition, value);
		}

		public gameuiForcePlayerCustomizationData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
