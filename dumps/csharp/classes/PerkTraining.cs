using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerkTraining : InteractiveDevice
	{
		private CString _progressBarHeaderText;
		private CString _progressBarBottomText;
		private CName _pulsingEndSoundName;
		private CHandle<AnimFeature_PerkDeviceData> _animFeature;
		private CHandle<entSlotComponent> _uiSlots;

		[Ordinal(98)] 
		[RED("progressBarHeaderText")] 
		public CString ProgressBarHeaderText
		{
			get => GetProperty(ref _progressBarHeaderText);
			set => SetProperty(ref _progressBarHeaderText, value);
		}

		[Ordinal(99)] 
		[RED("progressBarBottomText")] 
		public CString ProgressBarBottomText
		{
			get => GetProperty(ref _progressBarBottomText);
			set => SetProperty(ref _progressBarBottomText, value);
		}

		[Ordinal(100)] 
		[RED("pulsingEndSoundName")] 
		public CName PulsingEndSoundName
		{
			get => GetProperty(ref _pulsingEndSoundName);
			set => SetProperty(ref _pulsingEndSoundName, value);
		}

		[Ordinal(101)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_PerkDeviceData> AnimFeature
		{
			get => GetProperty(ref _animFeature);
			set => SetProperty(ref _animFeature, value);
		}

		[Ordinal(102)] 
		[RED("uiSlots")] 
		public CHandle<entSlotComponent> UiSlots
		{
			get => GetProperty(ref _uiSlots);
			set => SetProperty(ref _uiSlots, value);
		}

		public PerkTraining(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
