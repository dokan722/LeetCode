#include "problem_2092.h"

#include <algorithm>
#include <unordered_set>

bool problem_2092::test() {
    int n = 4;
    std::vector<std::vector<int>> meetings { { 3, 1, 3 }, { 1, 2, 2 }, { 0, 3, 3 } };
    int firstPerson = 3;

    std::vector expected { 0, 1, 3 };

    auto result = findAllPeople(n, meetings, firstPerson);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_2092::findAllPeople(int n, std::vector<std::vector<int>> &meetings, int firstPerson) {
    std::vector<int> ubf(n);
    for (int i = 0; i < n; i++)
        ubf[i] = i;
    un(0, firstPerson, ubf);
    std::sort(meetings.begin(), meetings.end(), [] (const std::vector<int>& a, const std::vector<int>& b) { return a[2] < b[2]; });
    std::unordered_set<int> present;
    int prev = meetings[0][2];
    for (auto meeting : meetings)
    {
        if (prev != meeting[2])
        {
            for (auto p : present)
            {
                if (find(p, ubf) == 0)
                    ubf[p] = 0;
                else
                    ubf[p] = p;
            }
            prev = meeting[2];
            present.clear();
        }
        present.insert(meeting[0]);
        present.insert(meeting[1]);
        un(meeting[0], meeting[1], ubf);
    }
    std::vector<int> result;
    for (int i = 0; i < n; ++i)
    {
        if (find(i, ubf) == 0)
            result.push_back(i);
    }
    return result;
}

int problem_2092::find(int x, std::vector<int> &ubf) {
    if (x == ubf[x])
        return x;
    return find(ubf[x], ubf);
}

void problem_2092::un(int x, int y, std::vector<int> &ubf) {
    auto px = find(x, ubf);
    auto py = find(y, ubf);
    if (py == 0)
        ubf[px] = 0;
    else
        ubf[py] = px;
}
