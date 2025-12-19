#ifndef PROBLEMS_PROBLEM_2092_H
#define PROBLEMS_PROBLEM_2092_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2092 : public problem {
public:
    bool test() override;

    std::vector<int> findAllPeople(int n, std::vector<std::vector<int>>& meetings, int firstPerson);
private:
    int find(int x, std::vector<int>& ubf);
    void un(int x, int y, std::vector<int>& ubf);
};

#endif //PROBLEMS_PROBLEM_2092_H