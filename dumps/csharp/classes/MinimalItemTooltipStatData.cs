using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinimalItemTooltipStatData : IScriptable
	{
		private CFloat _value;
		private CFloat _diff;
		private CString _statName;
		private CEnum<gamedataStatType> _type;
		private CInt32 _decimalPlaces;
		private CBool _displayPercent;
		private CBool _displayPlus;
		private CBool _inMeters;
		private CBool _inSeconds;
		private CBool _inSpeed;
		private CBool _multiplyBy100InText;
		private CBool _roundValue;
		private CBool _flipNegative;

		[Ordinal(0)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(1)] 
		[RED("diff")] 
		public CFloat Diff
		{
			get => GetProperty(ref _diff);
			set => SetProperty(ref _diff, value);
		}

		[Ordinal(2)] 
		[RED("statName")] 
		public CString StatName
		{
			get => GetProperty(ref _statName);
			set => SetProperty(ref _statName, value);
		}

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<gamedataStatType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(4)] 
		[RED("decimalPlaces")] 
		public CInt32 DecimalPlaces
		{
			get => GetProperty(ref _decimalPlaces);
			set => SetProperty(ref _decimalPlaces, value);
		}

		[Ordinal(5)] 
		[RED("displayPercent")] 
		public CBool DisplayPercent
		{
			get => GetProperty(ref _displayPercent);
			set => SetProperty(ref _displayPercent, value);
		}

		[Ordinal(6)] 
		[RED("displayPlus")] 
		public CBool DisplayPlus
		{
			get => GetProperty(ref _displayPlus);
			set => SetProperty(ref _displayPlus, value);
		}

		[Ordinal(7)] 
		[RED("inMeters")] 
		public CBool InMeters
		{
			get => GetProperty(ref _inMeters);
			set => SetProperty(ref _inMeters, value);
		}

		[Ordinal(8)] 
		[RED("inSeconds")] 
		public CBool InSeconds
		{
			get => GetProperty(ref _inSeconds);
			set => SetProperty(ref _inSeconds, value);
		}

		[Ordinal(9)] 
		[RED("inSpeed")] 
		public CBool InSpeed
		{
			get => GetProperty(ref _inSpeed);
			set => SetProperty(ref _inSpeed, value);
		}

		[Ordinal(10)] 
		[RED("multiplyBy100InText")] 
		public CBool MultiplyBy100InText
		{
			get => GetProperty(ref _multiplyBy100InText);
			set => SetProperty(ref _multiplyBy100InText, value);
		}

		[Ordinal(11)] 
		[RED("roundValue")] 
		public CBool RoundValue
		{
			get => GetProperty(ref _roundValue);
			set => SetProperty(ref _roundValue, value);
		}

		[Ordinal(12)] 
		[RED("flipNegative")] 
		public CBool FlipNegative
		{
			get => GetProperty(ref _flipNegative);
			set => SetProperty(ref _flipNegative, value);
		}

		public MinimalItemTooltipStatData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
