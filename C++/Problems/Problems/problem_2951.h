#ifndef PROBLEM_2951_H
#define PROBLEM_2951_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2951 : public problem {
public:
    bool test() override;

    std::vector<int> findPeaks(std::vector<int>& mountain);
};

#endif //PROBLEM_2951_H
