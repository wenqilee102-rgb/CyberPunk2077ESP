using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StimIdentificationData : CVariable
	{
		private entEntityID _sourceID;
		private CEnum<gamedataStimType> _stimType;
		private CName _stimName;
		private gameDelayID _delayID;

		[Ordinal(0)] 
		[RED("sourceID")] 
		public entEntityID SourceID
		{
			get => GetProperty(ref _sourceID);
			set => SetProperty(ref _sourceID, value);
		}

		[Ordinal(1)] 
		[RED("stimType")] 
		public CEnum<gamedataStimType> StimType
		{
			get => GetProperty(ref _stimType);
			set => SetProperty(ref _stimType, value);
		}

		[Ordinal(2)] 
		[RED("stimName")] 
		public CName StimName
		{
			get => GetProperty(ref _stimName);
			set => SetProperty(ref _stimName, value);
		}

		[Ordinal(3)] 
		[RED("delayID")] 
		public gameDelayID DelayID
		{
			get => GetProperty(ref _delayID);
			set => SetProperty(ref _delayID, value);
		}

		public StimIdentificationData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
