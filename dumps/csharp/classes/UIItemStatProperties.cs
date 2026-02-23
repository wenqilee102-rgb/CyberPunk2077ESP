using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIItemStatProperties : IScriptable
	{
		private CString _localizedName;
		private CInt32 _decimalPlaces;
		private CBool _displayPercent;
		private CBool _displayPlus;
		private CBool _inMeters;
		private CBool _inSeconds;
		private CBool _inSpeed;
		private CBool _multiplyBy100InText;
		private CBool _roundValue;
		private CFloat _maxValue;
		private CBool _flipNegative;

		[Ordinal(0)] 
		[RED("localizedName")] 
		public CString LocalizedName
		{
			get => GetProperty(ref _localizedName);
			set => SetProperty(ref _localizedName, value);
		}

		[Ordinal(1)] 
		[RED("decimalPlaces")] 
		public CInt32 DecimalPlaces
		{
			get => GetProperty(ref _decimalPlaces);
			set => SetProperty(ref _decimalPlaces, value);
		}

		[Ordinal(2)] 
		[RED("displayPercent")] 
		public CBool DisplayPercent
		{
			get => GetProperty(ref _displayPercent);
			set => SetProperty(ref _displayPercent, value);
		}

		[Ordinal(3)] 
		[RED("displayPlus")] 
		public CBool DisplayPlus
		{
			get => GetProperty(ref _displayPlus);
			set => SetProperty(ref _displayPlus, value);
		}

		[Ordinal(4)] 
		[RED("inMeters")] 
		public CBool InMeters
		{
			get => GetProperty(ref _inMeters);
			set => SetProperty(ref _inMeters, value);
		}

		[Ordinal(5)] 
		[RED("inSeconds")] 
		public CBool InSeconds
		{
			get => GetProperty(ref _inSeconds);
			set => SetProperty(ref _inSeconds, value);
		}

		[Ordinal(6)] 
		[RED("inSpeed")] 
		public CBool InSpeed
		{
			get => GetProperty(ref _inSpeed);
			set => SetProperty(ref _inSpeed, value);
		}

		[Ordinal(7)] 
		[RED("multiplyBy100InText")] 
		public CBool MultiplyBy100InText
		{
			get => GetProperty(ref _multiplyBy100InText);
			set => SetProperty(ref _multiplyBy100InText, value);
		}

		[Ordinal(8)] 
		[RED("roundValue")] 
		public CBool RoundValue
		{
			get => GetProperty(ref _roundValue);
			set => SetProperty(ref _roundValue, value);
		}

		[Ordinal(9)] 
		[RED("maxValue")] 
		public CFloat MaxValue
		{
			get => GetProperty(ref _maxValue);
			set => SetProperty(ref _maxValue, value);
		}

		[Ordinal(10)] 
		[RED("flipNegative")] 
		public CBool FlipNegative
		{
			get => GetProperty(ref _flipNegative);
			set => SetProperty(ref _flipNegative, value);
		}

		public UIItemStatProperties(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
