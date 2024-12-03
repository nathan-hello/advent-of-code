﻿Console.WriteLine("Day 01 : Part 1 = {0}", new Day1().Part1());
Console.WriteLine("Day 01 : Part 2 = {0}", new Day1().Part2());

public class Day1
{
    private int[] left = [35039, 61770, 64079, 61538, 77448, 56882, 72415, 11288, 43897, 56727, 81287, 66133, 21274, 65927, 43275, 29504, 73071, 25249, 51211, 19572, 26142, 25609, 10036, 97258, 88301, 89401, 89964, 26207, 34775, 55537, 35189, 74815, 98408, 66083, 81768, 86028, 78015, 26525, 50652, 46529, 27670, 20278, 36953, 98021, 98347, 39347, 86168, 82505, 78290, 12165, 70134, 60561, 92644, 70402, 81492, 67344, 83806, 46148, 35372, 70501, 36437, 13351, 65114, 67941, 16939, 43099, 60351, 92943, 33652, 73828, 55163, 57218, 76645, 36564, 64261, 67963, 49372, 69480, 32198, 38665, 32951, 53576, 39656, 71183, 66472, 24301, 40984, 65961, 55309, 20630, 55278, 58661, 47209, 30844, 46280, 73348, 37023, 43890, 34095, 60970, 16343, 41706, 87020, 46949, 37286, 54991, 72476, 96012, 79020, 11027, 98640, 78434, 29492, 45088, 13223, 17492, 45464, 94266, 46126, 80482, 49680, 15609, 48176, 74567, 89131, 42284, 56347, 87384, 80786, 15632, 48967, 80552, 71754, 71067, 91984, 77319, 85675, 54205, 39928, 13379, 87496, 32723, 62186, 78491, 10168, 24088, 57858, 10823, 97894, 70019, 41477, 15662, 25093, 29323, 18936, 17295, 52810, 13042, 57453, 45958, 53286, 65171, 52645, 89111, 69190, 34165, 98963, 13170, 87920, 22074, 37187, 20513, 64242, 81762, 88574, 63069, 32411, 13788, 86602, 53911, 30069, 98867, 79357, 29837, 24479, 46309, 24235, 50071, 61057, 95148, 58070, 16637, 31912, 38708, 96787, 75417, 20360, 17721, 58217, 49000, 59036, 77409, 79817, 30649, 96917, 95214, 82654, 88953, 78903, 21690, 18483, 29927, 51783, 55701, 45673, 73231, 59005, 91304, 58464, 78321, 78012, 83185, 44548, 71438, 78713, 71210, 46581, 62438, 67039, 16702, 88676, 73310, 76088, 87385, 83592, 58366, 15476, 26310, 38036, 60018, 81012, 38923, 47082, 89518, 56737, 51077, 32515, 18923, 74717, 13418, 18592, 25055, 23882, 95286, 19221, 60544, 80751, 34121, 48090, 84168, 94488, 80097, 36689, 79604, 39541, 30503, 99952, 85883, 70810, 98805, 43305, 82380, 67400, 62408, 25541, 65499, 84214, 70938, 79681, 73505, 83713, 84354, 48548, 12840, 78716, 45910, 47560, 47112, 67023, 20967, 49248, 87199, 12263, 57425, 90601, 15977, 61849, 32331, 83097, 12136, 86788, 28393, 86736, 61864, 72683, 54597, 65421, 17857, 37720, 68978, 57267, 18517, 32657, 21859, 76476, 53312, 70428, 49968, 50579, 50939, 76445, 53041, 39271, 72567, 74117, 25221, 88816, 60219, 35361, 92810, 17644, 46040, 92989, 17635, 68783, 20873, 85545, 21896, 81831, 57455, 81437, 13477, 41826, 91906, 48905, 19734, 93363, 15273, 32150, 88323, 50438, 77527, 66427, 41801, 64461, 53184, 87733, 97848, 35602, 82441, 77772, 36120, 45634, 24893, 57112, 40409, 80879, 92096, 69320, 78612, 44562, 77278, 73599, 16357, 76061, 29005, 40702, 70153, 57420, 86348, 92063, 47800, 60458, 15178, 89187, 73964, 29307, 96451, 17193, 79179, 53513, 40638, 43355, 40482, 13852, 35615, 26073, 23480, 21199, 67810, 63103, 19976, 37087, 34113, 21162, 57585, 51300, 98474, 57264, 34212, 93328, 75849, 90445, 93916, 46798, 82528, 74563, 67135, 15607, 66246, 16903, 45766, 59997, 81887, 29485, 80979, 20258, 70699, 82045, 45777, 82525, 92652, 96844, 28035, 86365, 78926, 95946, 43893, 28609, 87219, 93438, 97030, 59943, 29365, 98717, 64822, 38180, 37631, 79526, 96038, 15216, 91027, 19057, 77022, 30822, 99607, 85679, 62825, 70683, 38177, 46156, 92147, 51291, 46318, 89248, 90901, 47593, 59516, 21660, 95391, 38263, 70156, 49825, 21562, 19126, 27772, 26534, 12314, 32251, 20686, 84143, 38364, 51507, 67556, 21631, 64229, 39986, 47714, 73986, 69949, 17270, 99432, 48531, 46876, 40461, 20823, 72811, 98823, 20633, 42316, 44514, 42377, 49072, 69408, 53679, 52198, 85786, 30578, 46225, 45255, 31920, 90804, 80275, 68662, 89110, 42356, 67432, 84587, 98965, 39298, 20305, 72893, 48498, 56034, 69371, 75052, 57465, 97772, 75434, 18868, 86813, 43611, 66792, 69469, 18458, 38462, 87928, 96353, 53118, 74425, 61527, 72699, 28361, 65201, 91574, 37942, 72588, 71168, 48459, 31869, 29588, 97291, 70794, 22214, 59680, 32724, 94621, 21207, 30806, 97672, 14543, 39613, 32528, 83946, 91301, 80822, 26200, 73062, 23869, 92502, 74516, 27497, 36478, 92908, 11876, 26026, 84224, 13289, 76102, 74301, 96021, 40398, 36289, 39559, 70127, 61244, 45691, 16076, 33843, 18684, 20708, 42761, 17831, 24140, 89681, 83750, 82004, 27972, 75904, 99833, 11155, 66716, 80735, 85266, 98337, 92888, 11445, 79766, 27583, 70045, 80793, 33110, 69622, 90263, 32835, 13365, 83143, 64478, 15324, 50087, 42350, 71842, 66498, 13071, 27992, 57580, 52296, 96307, 97907, 73611, 16524, 83155, 81077, 90337, 65045, 73257, 52515, 62707, 78188, 67413, 33346, 76327, 61151, 89156, 11898, 69189, 78225, 60768, 79015, 42403, 22916, 31157, 97212, 88285, 73376, 62173, 29269, 79291, 33370, 25310, 46324, 92932, 78964, 67824, 74235, 66230, 53615, 26606, 66102, 71342, 43935, 48013, 27841, 12668, 85915, 88982, 52956, 16219, 65720, 65661, 44967, 65337, 32906, 60498, 49603, 91525, 10320, 36040, 94564, 13322, 85023, 48157, 45995, 98955, 64728, 15368, 14567, 65376, 26937, 75730, 42888, 92222, 40465, 37319, 25266, 91578, 24497, 34488, 48385, 36998, 37862, 42042, 64800, 58927, 20943, 80514, 38460, 97979, 65486, 66208, 59095, 24912, 54521, 41819, 75618, 14857, 55033, 11219, 24108, 72748, 50491, 56384, 28634, 23410, 31083, 71316, 67358, 55099, 10599, 27672, 73375, 92311, 60872, 71479, 30419, 78607, 99993, 22065, 72059, 45371, 77264, 95079, 84890, 64193, 70500, 67215, 58345, 20641, 90141, 18794, 34989, 88494, 45338, 49537, 38474, 62500, 28881, 47575, 82557, 15494, 92399, 47677, 69368, 50414, 86571, 81985, 83036, 27496, 82780, 41459, 51973, 22097, 23186, 87792, 98725, 60991, 40941, 38467, 97787, 61685, 94917, 91080, 23026, 21041, 35643, 47616, 63750, 55875, 68900, 39807, 72815, 58198, 48829, 86646, 55697, 69182, 76647, 98448, 33099, 23139, 60836, 85498, 28998, 51850, 14028, 62697, 43849, 76594, 39877, 31586, 84342, 50844, 78138, 79016, 71282, 17617, 64712, 15355, 77589, 77393, 47388, 72306, 85251, 16047, 46217, 41903, 87596, 28002, 12253, 18763, 26931, 42354, 35240, 70790, 88687, 45806, 63080, 10347, 35973, 12962, 65157, 80675, 24466, 76472, 87390, 67588, 22469, 43582, 37926, 29085, 71468, 44150, 75227, 27743, 42285, 28017, 39155, 24162, 67045, 43709, 20627, 87339, 99967, 84218, 96982, 71197, 16340, 61060, 83449, 95624, 59665, 73466, 28105, 30366, 77149, 33253, 85410, 58953, 11507, 84193, 67318, 40951, 32631, 25986, 34783, 64766, 32044, 81719, 41173, 46506, 80973, 37604, 14926, 46951, 34190, 72553, 56856, 73201, 29912, 49041, 27259, 54695, 17378, 97583, 28779, 95351, 21760, 42140, 77824, 45097, 67886, 50329, 14225, 99434, 74789, 78427, 84093, 54252, 92354, 46752, 46079, 65108, 82936, 96838, 78614, 82821, 24203, 30815, 58616, 49264, 84899, 13259, 92682, 96799, 62014, 58075, 35814, 34373, 14478, 86144, 60533, 81602, 29901, 85294, 12993, 27069, 61603, 97912, 58222, 58425, 68953, 45936, 28974, 12938, 70553, 15933, 89459, 16124, 13563, 47498, 31933, 31603, 62333, 87887, 46728, 96367, 17032, 74418, 62556, 88486, 36317, 43877, 43569, 16010, 37165, 45349, 32335, 39988, 89335, 30312, 60169, 91417, 10429, 42506, 99591, 57117, 29801, 43063, 56332, 45819,];
    private int[] right = [67568, 80134, 34668, 86348, 73688, 65376, 66733, 79847, 20133, 25055, 24301, 33989, 84409, 32516, 24301, 38180, 74577, 25055, 25055, 81012, 24568, 19866, 18923, 98885, 43877, 65376, 88401, 85319, 97035, 48593, 46866, 27672, 81549, 58944, 50255, 11898, 70810, 12863, 11386, 79454, 30786, 18592, 18592, 96012, 60521, 24301, 39900, 31605, 92399, 86348, 35240, 55192, 92932, 72092, 82771, 77389, 50491, 47616, 63378, 91984, 44056, 33618, 71154, 77586, 24301, 51685, 38065, 87339, 15509, 18923, 65670, 86022, 24301, 65376, 15607, 28041, 30366, 24952, 55284, 26207, 50459, 89578, 26580, 38180, 46811, 11898, 25055, 26207, 36953, 50491, 62239, 49521, 39735, 51389, 11898, 81012, 44793, 41616, 35240, 98021, 24742, 13472, 46256, 30366, 56301, 65376, 58147, 11747, 26847, 40409, 47616, 24301, 18923, 13012, 91906, 68439, 91984, 48022, 52475, 22341, 66039, 50491, 14926, 56332, 14926, 15607, 43877, 58198, 27672, 15059, 24301, 76081, 27698, 96012, 31229, 74172, 39838, 27186, 81012, 91984, 27672, 71218, 22864, 58198, 10989, 63750, 88400, 38180, 24301, 43544, 24301, 62524, 43463, 68118, 14926, 24996, 26207, 80773, 87339, 93542, 82302, 18711, 18592, 74154, 65073, 14035, 87280, 11898, 99570, 60255, 10919, 21640, 40409, 81683, 24301, 11898, 36953, 57579, 30639, 25055, 28957, 63750, 89335, 45181, 65376, 31558, 83946, 52395, 55937, 67530, 56332, 51656, 68437, 48382, 11059, 30401, 81012, 35393, 15987, 39785, 31112, 63750, 91906, 83513, 38760, 87339, 50242, 56447, 36434, 56874, 32272, 57208, 96512, 31292, 30830, 65376, 59694, 20527, 35240, 65376, 94439, 18923, 53764, 38847, 97359, 38895, 33845, 91906, 63750, 64076, 15607, 20399, 24301, 30775, 25900, 28870, 93690, 96738, 64685, 47223, 37166, 27672, 73538, 27672, 85410, 53083, 11482, 92879, 54461, 68933, 50395, 15496, 27770, 18923, 15607, 89335, 73667, 47616, 78382, 79627, 11836, 55090, 65376, 91566, 26207, 83946, 92399, 71286, 35240, 36248, 51003, 60967, 63750, 54292, 14926, 14611, 35240, 98496, 10716, 92399, 96917, 81012, 18592, 47616, 82662, 81012, 96719, 43877, 88120, 61095, 65376, 40221, 50018, 36953, 98021, 35240, 65376, 94453, 89795, 41894, 10416, 15607, 34888, 25055, 39332, 58675, 38288, 81012, 33480, 91984, 88466, 27672, 11485, 85410, 70156, 19427, 35240, 66978, 91984, 77399, 92932, 63750, 39074, 81120, 11310, 67033, 91299, 88487, 38180, 26207, 56516, 24301, 43877, 30990, 37590, 98021, 52037, 84232, 62502, 21094, 56130, 81012, 24594, 65576, 25594, 48335, 82986, 59774, 57904, 70156, 30366, 35846, 18700, 28247, 81879, 38180, 67876, 36634, 33402, 71912, 80925, 74492, 18923, 14926, 85410, 92399, 75264, 59223, 43877, 87552, 51272, 36322, 15607, 96012, 86663, 59024, 68245, 15607, 75466, 63766, 30366, 45272, 46100, 91984, 18592, 23709, 18310, 43665, 47616, 96012, 32008, 15884, 53777, 86348, 66624, 81012, 88178, 70156, 50442, 26207, 43803, 14574, 63073, 57605, 31607, 43679, 42337, 95224, 91906, 98763, 21275, 14926, 97357, 96467, 41426, 76844, 74751, 20376, 83946, 42725, 14625, 13145, 50491, 82899, 14150, 65376, 81911, 72454, 24301, 71343, 16823, 56332, 19789, 92093, 13503, 14227, 96518, 18592, 26207, 96012, 25055, 96012, 46482, 44009, 39063, 77298, 97782, 71831, 20838, 91984, 27672, 71842, 59391, 52566, 44464, 47776, 65376, 77572, 81012, 98021, 63750, 85410, 29642, 81012, 63750, 86348, 18923, 47616, 82343, 85410, 63297, 14926, 27672, 91984, 91984, 56019, 21362, 58104, 32463, 47616, 76903, 86348, 72918, 51842, 19709, 18923, 83907, 36953, 93199, 70518, 27540, 26207, 52164, 48879, 63750, 27672, 58198, 30862, 27513, 18592, 29536, 65985, 26207, 11898, 60093, 30366, 26207, 36953, 36356, 43020, 15432, 29097, 47616, 30366, 69702, 38439, 56426, 47154, 97151, 36452, 58910, 83506, 52629, 61450, 98021, 91906, 25723, 99510, 61226, 45072, 71257, 86348, 74969, 18707, 47204, 98021, 83823, 19691, 11898, 18923, 30366, 65376, 89835, 91984, 38953, 91906, 24301, 27672, 89328, 18923, 18923, 37295, 36953, 36953, 73535, 51828, 92633, 36621, 41864, 40409, 93120, 22746, 22030, 65339, 54602, 76443, 73571, 20377, 15607, 62049, 92399, 60849, 35240, 67257, 86242, 76500, 98171, 65376, 37369, 81012, 87339, 92399, 81012, 32845, 15607, 51380, 91906, 15607, 62467, 39937, 67541, 91906, 86756, 91906, 44952, 30366, 98899, 50893, 59867, 44885, 47616, 18923, 96238, 71723, 99821, 99950, 98021, 75273, 74030, 85429, 95947, 18425, 68822, 96033, 40785, 35240, 72585, 35240, 76016, 70156, 36953, 13181, 14926, 35240, 14926, 62903, 96012, 75995, 12058, 27672, 77569, 93991, 69978, 26207, 91984, 13393, 17892, 96917, 92932, 55783, 63704, 90249, 71842, 57778, 30366, 90111, 93590, 54781, 45061, 26330, 59054, 91906, 27672, 27672, 35240, 71842, 96012, 37786, 37117, 91906, 22687, 87339, 81973, 58586, 35662, 87195, 23421, 98021, 89964, 78685, 28971, 43877, 65376, 38654, 25055, 49297, 24301, 63750, 91984, 96012, 23616, 46633, 22665, 93894, 70713, 26207, 39636, 97075, 47616, 95892, 63750, 71842, 39433, 18592, 37888, 10049, 58198, 27235, 95870, 85289, 35240, 25055, 90687, 49808, 63750, 25055, 84517, 81012, 91906, 49180, 40206, 27672, 79368, 71842, 76733, 13893, 92399, 40409, 15607, 43877, 49775, 17215, 76108, 18592, 26163, 53151, 59156, 71842, 74041, 56218, 73106, 18592, 15666, 20042, 24301, 42619, 93788, 42797, 47094, 66687, 36792, 65920, 72231, 35240, 38180, 89172, 86348, 97784, 78461, 88210, 96012, 26207, 91906, 71842, 54596, 84958, 75407, 12224, 15607, 96012, 27672, 96012, 92932, 18239, 92399, 91083, 16699, 80033, 91984, 87216, 37021, 91527, 78293, 48322, 83946, 63750, 49444, 96012, 24301, 80706, 96917, 73702, 58436, 95578, 92399, 93326, 35240, 30366, 35240, 65376, 73885, 15464, 13922, 15607, 96012, 71640, 43376, 65376, 50491, 93669, 81012, 30366, 64905, 38180, 65655, 75133, 86491, 57039, 27747, 29704, 38406, 12228, 91906, 62160, 30366, 16252, 27672, 45618, 65376, 50491, 33041, 17316, 93648, 59231, 84987, 35251, 18592, 96808, 83946, 95802, 27672, 51892, 71842, 42023, 81012, 72862, 18592, 68144, 27672, 14926, 86088, 30366, 24392, 11436, 36953, 78289, 30366, 91634, 97144, 54401, 34032, 70442, 87339, 33729, 31090, 64702, 14427, 36953, 47616, 15607, 71842, 88463, 59086, 48950, 13547, 43877, 18093, 46889, 72435, 50140, 24103, 61159, 49253, 53382, 27672, 91984, 47616, 77734, 73477, 61592, 43681, 26207, 72855, 84388, 22611, 61407, 98021, 38292, 82605, 40409, 72169, 43032, 78869, 87905, 33741, 96420, 62692, 96066, 57799, 65753, 10632, 64315, 15607, 38764, 87339, 38180, 87339, 25230, 43877, 40409, 27672, 31632, 61404, 47616, 15607, 29186, 77098, 81012, 88349, 68764, 81012, 18923, 87864, 30366, 30366, 70515, 89297, 35240, 47516, 14507, 49156, 84142, 41244, 42417, 24301, 87339, 93674, 11898, 64137, 84748, 57841, 17449, 16921, 63750, 96606, 65376, 19808, 47077, 27815, 70902, 25055, 14417, 40949, 63750, 35240, 10274, 71842, 82234, 73144, 18923, 29200, 75561, 36348, 86894, 94318, 98220, 59594, 12118, 69410, 47919, 78661, 71247, 91906, 81059, 66262, 11898, 33050, 91906, 60465, 91906, 80462, 77404, 87339, 20368, 53213, 64028, 63037, 98690, 83946, 26207, 43299, 98021, 98021, 38381, 73168, 50960, 26207, 87339, 26207, 39519,];
    public Day1() { }
    public int Part1()
    {
        Array.Sort(left);
        Array.Sort(right);
        List<int> distances = [];
        for (int i = 0; i < left.Length; i++)
        {
            int[] curr = [left[i], right[i]];
            var dist = curr.Max() - curr.Min();
            distances.Add(dist);
        }
        return distances.Sum();
    }
    public int Part2()
    {
        List<int> similar = [];

        for (int i = 0; i < left.Length; i++)
        {
            int score = 0;
            for (int j = 0; j < right.Length; j++)
            {
                if (right[j] == left[i])
                {
                    score = score + 1;
                };
            }
            similar.Add(left[i] * score);
        }

        return similar.Sum();
    }
}
