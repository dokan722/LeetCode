//
// Created by peite on 24.06.2025.
//

#ifndef PROBLEM_2685_H
#define PROBLEM_2685_H



#include "../problem.h"
#include <vector>


class problem_2685 : public problem {
public:
    bool test() override;

    int countCompleteComponents(int n, std::vector<std::vector<int> > &edges);
};

class findUnion {
public:
    std::vector<int> Counts;

    explicit findUnion(int n) : Counts(n, 1), _vertices(n, -1) {}

    int Find(int x);
    void Union(int x, int y);
private:
    std::vector<int> _vertices;
};



#endif //PROBLEM_2685_H
