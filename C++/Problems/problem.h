#ifndef IPROBLEM_H
#define IPROBLEM_H
#include <iostream>
#include <vector>


class problem {
public:
    virtual ~problem() = default;

    virtual bool test() = 0;

    void printVector(std::vector<int> &arr);
};

inline void problem::printVector(std::vector<int> &arr) {
    for (int i = 0; i < arr.size() - 1; i++)
        std::cout << arr[i] << ", ";
    std::cout << arr[arr.size() - 1] << std::endl;
}

#endif
