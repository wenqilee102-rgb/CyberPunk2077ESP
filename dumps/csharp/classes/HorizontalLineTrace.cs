using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HorizontalLineTrace : AIbehaviorconditionScript
	{
		private CHandle<AIArgumentMapping> _source;
		private CHandle<AIArgumentMapping> _target;
		private CHandle<AIArgumentMapping> _offset;
		private CHandle<AIArgumentMapping> _length;
		private CHandle<AIArgumentMapping> _azimuth;

		[Ordinal(0)] 
		[RED("source")] 
		public CHandle<AIArgumentMapping> Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		[Ordinal(1)] 
		[RED("target")] 
		public CHandle<AIArgumentMapping> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(2)] 
		[RED("offset")] 
		public CHandle<AIArgumentMapping> Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(3)] 
		[RED("length")] 
		public CHandle<AIArgumentMapping> Length
		{
			get => GetProperty(ref _length);
			set => SetProperty(ref _length, value);
		}

		[Ordinal(4)] 
		[RED("azimuth")] 
		public CHandle<AIArgumentMapping> Azimuth
		{
			get => GetProperty(ref _azimuth);
			set => SetProperty(ref _azimuth, value);
		}

		public HorizontalLineTrace(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
