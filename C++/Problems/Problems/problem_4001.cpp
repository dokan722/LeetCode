#include "problem_4001.h"

bool problem_4001::test() {
    std::vector<std::vector<int>> series1 { { 1, 3 }, { 4, 1 } };
    std::vector<std::vector<int>> series2 { { 2, 2 }, { 5, 2 } };

    std::vector<std::vector<int>> expected { { 1, 5 }, { 2, 3 }, { 4, 3 }, { 5, 2 } };

    auto result = aggregateTimeSeries(series1, series2);

    print2DVector(result);

    return expected == result;
}

std::vector<std::vector<int>> problem_4001::aggregateTimeSeries(std::vector<std::vector<int>> &series1,
    std::vector<std::vector<int>> &series2) {
    int n = series1.size();
    int m = series2.size();
    int i = 0;
    int j = 0;
    std::vector<std::vector<int>> result;
    while (i < n || j < m)
    {
        std::vector<int> c1 = i < n ? series1[i] : std::vector { INT_MAX, 0 };
        std::vector<int> c2 = j < m ? series2[j] : std::vector { INT_MAX, 0 };
        if (c1[0] < c2[0])
        {
            result.push_back( { c1[0], c1[1] + c2[1] });
            i++;
        }
        else if (c1[0] > c2[0])
        {
            result.push_back( { c2[0], c1[1] + c2[1] });
            j++;
        }
        else
        {
            result.push_back( { c1[0], c1[1] + c2[1] });
            i++;
            j++;
        }
    }

    return result;
}
