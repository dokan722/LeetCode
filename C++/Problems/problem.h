#ifndef IPROBLEM_H
#define IPROBLEM_H
#include <iostream>
#include <vector>


class problem {
public:
    virtual ~problem() = default;

    virtual bool test() = 0;

    template<class T>
    void printVector(const std::vector<T> &arr);
};

template <typename T>
inline void problem::printVector(const std::vector<T> &arr) {
    for (int i = 0; i < arr.size() - 1; i++)
        std::cout << arr[i] << ", ";
    std::cout << arr[arr.size() - 1] << std::endl;
}

#endif