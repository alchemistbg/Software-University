using System;

namespace _02_Kamino_Factory
{
	class Program
	{
		static void Main(string[] args)
		{
			List<DNAseq> seqList = new List<DNAseq>();

			int seqSize = int.Parse(Console.ReadLine());

			string seqString = Console.ReadLine();
			int seqNumber = 1;
			while (seqString != "Clone them!")
			{
				int[] seqArr = seqString.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

				int Len = 1;
				int Start = 0;

				int bestLen = 0;
				int bestStart = 0;

				for (int i = 1; i < seqArr.Length; i++)
				{
					if (seqArr[i - 1] == seqArr[i])
					{
						Len++;
						if (bestLen < Len && bestStart < i)
						{
							bestLen = Len;
							bestStart = Start;
						}
					}
					else
					{
						Len = 1;
						Start = i;
					}
				}
				DNAseq seq = new DNAseq(seqString);
				seq.seqIndex = seqNumber;
				seq.seqArray = seqArr;
				seq.longestLength = bestLen;
				seq.longestIndex = bestStart;
				seqList.Add(seq);

				seqString = Console.ReadLine();
				seqNumber++;
			}

			foreach (DNAseq seq in seqList.OrderByDescending(x => x.longestLength).ThenBy(x => x.longestIndex).ThenByDescending(x => x.seqSum).Take(1))
			{
				Console.WriteLine($"Best DNA sample {seq.seqIndex} with sum: {seq.seqSum}.");
				Console.WriteLine(string.Join(" ", seq.seqArray));
			}
		}
	}

	class DNAseq
	{
		public string seqString { get; set; }
		public int seqIndex { get; set; }
		public int[] seqArray { get; set; }
		public int longestLength { get; set; }
		public int longestIndex { get; set; }
		public int seqSum
		{
			get
			{
				return seqArray.Sum();
			}
		}

		public DNAseq(string s)
		{
			this.seqString = s;
		}
	}
}
