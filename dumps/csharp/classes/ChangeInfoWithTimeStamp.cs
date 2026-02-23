using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChangeInfoWithTimeStamp : CVariable
	{
		private CFloat _timeStamp;
		private CFloat _change;

		[Ordinal(0)] 
		[RED("TimeStamp")] 
		public CFloat TimeStamp
		{
			get => GetProperty(ref _timeStamp);
			set => SetProperty(ref _timeStamp, value);
		}

		[Ordinal(1)] 
		[RED("Change")] 
		public CFloat Change
		{
			get => GetProperty(ref _change);
			set => SetProperty(ref _change, value);
		}

		public ChangeInfoWithTimeStamp(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
