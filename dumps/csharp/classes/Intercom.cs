using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Intercom : InteractiveDevice
	{
		private CBool _isShortGlitchActive;
		private gameDelayID _shortGlitchDelayID;
		private CName _dialStartSound;
		private CName _dialStopSound;
		private CName _distractionStartSound;
		private CName _distractionStopSound;
		private CName _answeredSound;

		[Ordinal(98)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetProperty(ref _isShortGlitchActive);
			set => SetProperty(ref _isShortGlitchActive, value);
		}

		[Ordinal(99)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetProperty(ref _shortGlitchDelayID);
			set => SetProperty(ref _shortGlitchDelayID, value);
		}

		[Ordinal(100)] 
		[RED("dialStartSound")] 
		public CName DialStartSound
		{
			get => GetProperty(ref _dialStartSound);
			set => SetProperty(ref _dialStartSound, value);
		}

		[Ordinal(101)] 
		[RED("dialStopSound")] 
		public CName DialStopSound
		{
			get => GetProperty(ref _dialStopSound);
			set => SetProperty(ref _dialStopSound, value);
		}

		[Ordinal(102)] 
		[RED("distractionStartSound")] 
		public CName DistractionStartSound
		{
			get => GetProperty(ref _distractionStartSound);
			set => SetProperty(ref _distractionStartSound, value);
		}

		[Ordinal(103)] 
		[RED("distractionStopSound")] 
		public CName DistractionStopSound
		{
			get => GetProperty(ref _distractionStopSound);
			set => SetProperty(ref _distractionStopSound, value);
		}

		[Ordinal(104)] 
		[RED("answeredSound")] 
		public CName AnsweredSound
		{
			get => GetProperty(ref _answeredSound);
			set => SetProperty(ref _answeredSound, value);
		}

		public Intercom(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
